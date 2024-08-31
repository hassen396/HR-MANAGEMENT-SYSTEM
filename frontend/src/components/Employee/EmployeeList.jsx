import React from 'react';

const EmployeeList = ({ employees }) => (
  <ul>
    {employees.map((employee) => (
      <li key={employee.id}>
        {employee.firstName} {employee.lastName} ({employee.email})
      </li>
    ))}
  </ul>
);

export default EmployeeList;
