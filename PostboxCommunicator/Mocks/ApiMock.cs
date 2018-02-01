using PostboxCommunicator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostboxCommunicator.Mocks {
    class ApiMock {

        public UserModel logUserIn(string login, string password) {
            UserModel user = new UserModel();
            user.id = "HarryPotter";
            user.displayName = "Mr Harry Potter, Gryffindor";

            return user; 
        }
    }
}
