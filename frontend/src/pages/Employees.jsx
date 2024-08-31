import { useEffect, useState } from 'react';
import EmployeeService from '../services/EmployeeService';
import EmployeeForm from '../components/Employee/EmployeeForm';
import EmployeeList from '../components/Employee/EmployeeList';

const Employees = () => {
  const [employees, setEmployees] = useState([]);

  useEffect(() => {
    const fetchEmployees = async () => {
      const response = await EmployeeService.getAll();
      setEmployees(response.data);
    };

    fetchEmployees();
  }, []);

  const handleAddEmployee = async (employee) => {
    await EmployeeService.add(employee);
    setEmployees([...employees, employee]);
  };

  return (
    <div>
      <h1>Employees</h1>
      <EmployeeForm onAddEmployee={handleAddEmployee} />
      <EmployeeList employees={employees} />
    </div>
  );
};

export default Employees;
