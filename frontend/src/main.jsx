import React from 'react';
import ReactDOM from 'react-dom/client';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import EmployeeList from './components/EmployeeList';
import EmployeeDetail from './components/EmployeeDetail';

const App = () => (
  <Router>
    <Routes>
      <Route path="/" element={<EmployeeList />} />
      <Route path="/employee/:id" element={<EmployeeDetail />} />
    </Routes>
  </Router>
);

ReactDOM.createRoot(document.getElementById('root')).render(<App />);
