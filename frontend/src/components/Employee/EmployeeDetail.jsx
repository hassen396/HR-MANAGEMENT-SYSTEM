import React, { useEffect, useState } from 'react';
import { fetchEmployeeById } from '../../services/EmployeeService';

const EmployeeDetails = ({ id }) => {
    const [employee, setEmployee] = useState(null);

    useEffect(() => {
        const getEmployee = async () => {
            const data = await fetchEmployeeById(id);
            setEmployee(data);
        };
        getEmployee();
    }, [id]);

    return (
        <div>
            {employee ? (
                <div>
                    <h2>{employee.firstName} {employee.lastName}</h2>
                    <p>Email: {employee.email}</p>
                    <p>Phone: {employee.phone}</p>
                </div>
            ) : (
                <p>Loading...</p>
            )}
        </div>
    );
};

export default EmployeeDetails;
