import axios from 'axios';

const API_URL = 'http://localhost:5000/api/employee';

const getAll = () => {
  return axios.get(API_URL);
};

const add = (employee) => {
  return axios.post(API_URL, employee);
};

export default {
  getAll,
  add,
};
