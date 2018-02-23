using Newtonsoft.Json;
using PostboxCommunicator.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;


namespace PostboxCommunicator.Infrastructure {
    public sealed class ClientServerCommunication {
        private static readonly ClientServerCommunication instance = new ClientServerCommunication();
        private static readonly HttpClient hClient = new HttpClient {BaseAddress = new Uri("http://localhost:3000/")};
        public WebSocket sock;
        

        private ClientServerCommunication() {
        }

        //Singleton
        public static ClientServerCommunication Instance{
            get
            {
                return instance;
            }
            
        }

        public async Task<string> login (LoginModel loginDetails) {
            StringContent content = new StringContent(JsonConvert.SerializeObject(loginDetails),
                Encoding.UTF8, "application/json");
            HttpResponseMessage response = await hClient.PostAsync("api/login", content);
            string error = await response.Content.ReadAsStringAsync();

            if (error == "") { 
                connect();
                return "true";
            }
            return error;
        }

        private void connect(){
            sock = new WebSocket("ws://localhost:8080");

            sock.OnOpen += (sender, e) => {
                Console.WriteLine("onOpen");
                
            };
            sock.Connect();


            sock.OnMessage += (sender, e) => {
                //method from ui to pass message to.
            };
        }

        public void joinList(){
            var json = $"{{ \"connection\": \"{"user1"}\"}}";
            sock.Send(json);
        }

        public void sendMessage(MessageModel message){
            string messageString= JsonConvert.SerializeObject(message);
            sock.Send(messageString);
        }

        public async Task<List<UserModel>> getUsers() {
            List<UserModel> users = new List<UserModel>();
  
            HttpResponseMessage response = await hClient.GetAsync("api/getUsers");
            users = JsonConvert.DeserializeObject<List<UserModel>>(response.Content.ReadAsStringAsync().Result);

            return users;
            //check response successful.
            //https://docs.microsoft.com/en-us/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client
        }




        //connect to server
        //login

        //if login successful
        //start web socket connection
        //successful?
        //get list of users
        //broadcast who's online

        //send message
        //rec message
    }
}
