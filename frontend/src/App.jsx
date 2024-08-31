// import React from 'react'
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom'
// import Home from './pages/Home'
import Employees from './pages/Employees'
// import Departments from './pages/Departments'
// import JobPositions from './pages/JobPositions'

const App = () => {
  return (
    <>
    <p>this comes from the App.jsx</p>
    <Router>
      <Routes>
        {/* <Route path='/' element={<Home />} /> */}
        <Route path='/employees' element={<Employees />} />
        {/* <Route path='/departments' element={<Departments />} /> */}
        {/* <Route path='/job-positions' element={<JobPositions />} /> */}
      </Routes>
    </Router>
    </>
  )
}

export default App
