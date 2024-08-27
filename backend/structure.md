HRSystem
│
├── HRSystem.API
│   ├── Controllers
│   │   ├── EmployeeController.cs
│   │   ├── DepartmentController.cs
│   │   ├── JobPositionController.cs
│   │   ├── LeaveRequestController.cs
│   │   ├── AttendanceController.cs
│   │   └── PayrollController.cs
│   ├── Program.cs
│   └── Startup.cs
│
├── HRSystem.Domain
│   ├── Entities
│   │   ├── Employee.cs
│   │   ├── Department.cs
│   │   ├── JobPosition.cs
│   │   ├── LeaveRequest.cs
│   │   ├── Attendance.cs
│   │   └── Payroll.cs
│   ├── ValueObjects
│   │   ├── Address.cs
│   │   └── ContactInfo.cs
│   ├── Repositories
│   │   ├── IEmployeeRepository.cs
│   │   ├── IDepartmentRepository.cs
│   │   ├── IJobPositionRepository.cs
│   │   ├── ILeaveRequestRepository.cs
│   │   ├── IAttendanceRepository.cs
│   │   └── IPayrollRepository.cs
│   └── Services
│       ├── EmployeeService.cs
│       ├── DepartmentService.cs
│       ├── JobPositionService.cs
│       ├── LeaveRequestService.cs
│       ├── AttendanceService.cs
│       └── PayrollService.cs
│
├── HRSystem.Application
│   ├── Interfaces
│   │   ├── IEmployeeService.cs
│   │   ├── IDepartmentService.cs
│   │   ├── IJobPositionService.cs
│   │   ├── ILeaveRequestService.cs
│   │   ├── IAttendanceService.cs
│   │   └── IPayrollService.cs
│   ├── DTOs
│   │   ├── EmployeeDTO.cs
│   │   ├── DepartmentDTO.cs
│   │   ├── JobPositionDTO.cs
│   │   ├── LeaveRequestDTO.cs
│   │   ├── AttendanceDTO.cs
│   │   └── PayrollDTO.cs
│   └── Mappers
│       ├── EmployeeMapper.cs
│       ├── DepartmentMapper.cs
│       ├── JobPositionMapper.cs
│       ├── LeaveRequestMapper.cs
│       ├── AttendanceMapper.cs
│       └── PayrollMapper.cs
│
├── HRSystem.Persistence
│   ├── Context
│   │   └── AppDbContext.cs
│   ├── Repositories
│   │   ├── EmployeeRepository.cs
│   │   ├── DepartmentRepository.cs
│   │   ├── JobPositionRepository.cs
│   │   ├── LeaveRequestRepository.cs
│   │   ├── AttendanceRepository.cs
│   │   └── PayrollRepository.cs
│   └── Migrations
│
└── HRSystem.SharedKernel
    ├── Extensions
    ├── Helpers
    ├── Constants
    └── Enums
