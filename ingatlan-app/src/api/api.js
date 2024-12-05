import axios from 'axios';

const apiClient = axios.create({
  baseURL: 'http://localhost:5000/api', // Az ASP.NET backend URL-je
  headers: {
    'Content-Type': 'application/json',
  },
});

export default {
  getItems() {
    return apiClient.get('/items');
  },
};