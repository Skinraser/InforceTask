import axios from 'axios';

const API_URL = `https://localhost:7297/URL/`;

class UrlService {
   
    async shortenUrl(url, userId){
        return axios.post(API_URL + "shortUrl", {url, userId})
    }
    async getUrls() {
        return axios.get(API_URL + "getUrls/")
    }
    async getUrlById(id){
        return axios.get(API_URL + "getUrl/" + id, id)
    }
    async deleteUrl(id) {
        return axios.delete(API_URL + "delete/" + id, id)
    }
}

export default new UrlService();