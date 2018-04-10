using PostboxCommunicator.Models;
using System;
using System.Collections;

namespace PostboxCommunicator.Mocks {
    class ApiMock {
        public static String[] users = {"Harry Potter", "Hermiona Granger", "Draco Malfoy", "Ronald Weasley", "Ginny Weasley", "Neville Longbottom"}; 

        public UserModel logUserIn(string login, string password) {
            UserModel user = new UserModel();
            user.username = "HarryPotter";
            user.displayName = "Mr Harry Potter, Gryffindor";

            return user; 
        }

        public static ArrayList getListOfContacts() {
            ArrayList userModels = new ArrayList(); 
            foreach( string user in ApiMock.users ) {
                UserModel pupil = new UserModel();
                pupil.username = user.Replace(" ", String.Empty);
                pupil.displayName = user;
                userModels.Add(pupil);
            }
            return userModels; 
        }
    }
}
