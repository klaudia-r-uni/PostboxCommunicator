using Newtonsoft.Json;
using PostboxCommunicator.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using WebSocketSharp;


namespace PostboxCommunicator.Infrastructure {
    public sealed class ClientServerCommunication {
        private static readonly ClientServerCommunication instance = new ClientServerCommunication();
        private static readonly HttpClient hClient = new HttpClient {BaseAddress = new Uri("http://138.68.171.7") };
        private WebSocket sock;
        public UserModel client;
        private ContactListView contacts;


        private ClientServerCommunication() {
        }

        //Singleton
        public static ClientServerCommunication Instance{
            get{
                return instance;
            }

        }

        public async Task<string> login (LoginModel loginDetails) {
            StringContent content = new StringContent(JsonConvert.SerializeObject(loginDetails), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await hClient.PostAsync("api/login", content);
            string objString = await response.Content.ReadAsStringAsync();

            var retObj = JObject.Parse(objString);
            var error = retObj["error"].ToString();

            if (error != "") return error;

            connect();
            client = new UserModel();
            client.username = retObj["result"][0]["username"].ToString();
            client.displayName = retObj["result"][0]["displayName"].ToString();

            return "";
        }

        private void connect(){
            sock = new WebSocket("ws://138.68.171.7:443");

            sock.OnOpen += (sender, e) => {
                //To be left in as OnOpen cannot be empty.
                Console.WriteLine("onOpen");
            };

            sock.Connect();

            sock.OnMessage += (sender, e) => {
                if (!e.Data.Contains("senderId")){
                    var onlineUsers = JsonConvert.DeserializeObject<List<string>>(e.Data);
                    onlineUsers.Remove(client.username);
                    contacts.updateOnlineUsers(onlineUsers);
                }
                else{
                    MessageModel message = JsonConvert.DeserializeObject<MessageModel>(e.Data);
                    if (contacts.isOpen(message.senderId)){
                        contacts.getConversation(message.senderId).recMessage(message);
                    }
                    else{
                        Console.WriteLine("notification");
                        //contacts.setNotification();
                    }
                }
            };
        }

        public void joinList(){
            var json = $"{{ \"connection\": \"{client.username}\"}}";
            sock.Send(json);
        }

        public void sendMessage(MessageModel message){
            string messageString= JsonConvert.SerializeObject(message);
            sock.Send(messageString);
        }

        public async Task<List<UserModel>> getUsers() {
            HttpResponseMessage response = await hClient.GetAsync("api/getUsers");

            return JsonConvert.DeserializeObject<List<UserModel>>(response.Content.ReadAsStringAsync().Result);
        }

        public async Task<List<MessageModel>> getMessages(int upper, string sender, string receiver){
            var conversation = new[]{
                new { senderId = sender, recipientId = receiver, upper = upper}
            };

            var convData = JsonConvert.SerializeObject(conversation);

            StringContent content = new StringContent(convData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await hClient.PostAsync("api/getMessages", content);

            return JsonConvert.DeserializeObject<List<MessageModel>>(response.Content.ReadAsStringAsync().Result);
        }


        public void setContacts(ContactListView contacts){
            this.contacts = contacts;
        }

        public void logout(){
            var json = $"{{ \"disconnect\": \"{client.username}\"}}";
            sock.Send(json);
        }
    }
}
