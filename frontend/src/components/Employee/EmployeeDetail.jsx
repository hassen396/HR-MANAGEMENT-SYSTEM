import { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';
import axios from 'axios';
import 'bootstrap/dist/css/bootstrap.min.css';

const EmployeeDetail = () => {
  const { id } = useParams();
  const [employee, setEmployee] = useState(null);

  useEffect(() => {
    axios
      .get(`http://localhost:5000/api/employee/${id}`)
      .then(response => {
        setEmployee(response.data);
      })
      .catch(error => {
        console.error('There was an error fetching the employee details!', error);
      });
  }, [id]);

  if (!employee) {
    return <p>Loading...</p>;
  }

  return (
    <div className="container mt-5">
      <h2>Employee Details</h2>
      <ul className="list-group">
        <li className="list-group-item">
          <strong>ID:</strong> {employee.id}
        </li>
        <li className="list-group-item">
          <strong>First Name:</strong> {employee.firstName}
        </li>
        <li className="list-group-item">
          <strong>Last Name:</strong> {employee.lastName}
        </li>
        <li className="list-group-item">
          <strong>Email:</strong> {employee.email}
        </li>
        <li className="list-group-item">
          <strong>Phone:</strong> {employee.phone}
        </li>
      </ul>
    </div>
  );
};

export default EmployeeDetail;
