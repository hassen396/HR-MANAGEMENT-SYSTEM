import { useParams } from 'react-router-dom';
import { useState, useEffect } from 'react';
import axios from 'axios';

const EmployeeDetail = () => {
    const { id } = useParams();  // Get employee ID from URL
    const [employee, setEmployee] = useState(null);

    useEffect(() => {
        axios.get(`http://localhost:5000/api/employee/${id}`)
            .then(response => {
                setEmployee(response.data);
            })
            .catch(error => {
                console.error('There was an error fetching the employee details!', error);
            });
    }, [id]);

    if (!employee) return <p>Loading...</p>;

    return (
        <div className="container mt-6">
            <h1 className="mb-4">Employee Details</h1>
            <div className="card">
                <div className="card-body">
                    <h5 className="card-title">{employee.firstName} {employee.lastName}</h5>
                    <p className="card-text">Email: {employee.email}</p>
                    <p className="card-text">Phone: {employee.phone}</p>
                </div>
            </div>
        </div>
    );
}

export default EmployeeDetail;
