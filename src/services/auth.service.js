import axios from 'axios';

const API_URL = `https://localhost:7297/User/`;

class AuthService {

    async signup(email,username,password){
        return axios.post(API_URL + "signup", {email,password,username})
        .then(()=> {
            return true
        });
    }

    async login(Email, Password) {
        return axios.post(API_URL + "login", {Email, Password}
        );
    }
    getUser(email){
        return axios.get(API_URL + "getuser" + email, {
            email
        }, 
        ).then(response=> {
            return response;
        })
    }
    logout() {
        localStorage.removeItem("user");
    }

    isLoggedIn() {
        return localStorage.getItem('user');;
    }

    getCurrentUser() {
        return JSON.parse(localStorage.getItem('user'));;
      }
}

export default new AuthService();