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
    class ClientServerCommunication {
        private static ClientServerCommunication instance;
        private static HttpClient hClient;
        public WebSocket sock;

        private ClientServerCommunication() {
            hClient = new HttpClient();
            hClient.BaseAddress = new Uri("http://localhost:3000/");
        }

        //Singleton
        public static ClientServerCommunication getInstance() {
            if (instance == null) {
                instance = new ClientServerCommunication();
            }

            return instance;
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

        private void connect() {
            sock = new WebSocket("ws://localhost:8080");
            sock.OnOpen += (sender, e) => {
                Console.WriteLine("onOpen");
            };
            sock.Connect();


            sock.OnMessage += (sender, e) => {
                //method from ui to pass message to.
            };
        }

        public void sendMessage(NewMessageModel message){
            string messageString= JsonConvert.SerializeObject(message);
            sock.Send(messageString);
        }

        public async Task<string> getUsers() {

            HttpResponseMessage response = await hClient.GetAsync("api/getUsers");
            string users = await response.Content.ReadAsStringAsync();

            return users;
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
