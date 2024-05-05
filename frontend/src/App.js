import logo from './logo.svg';
import './App.css';
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import { Footer, Navbar } from './Components';
import { Employee, Home,Grouper } from './Pages';
import Supervisor from './Components/Supervisor/Supervisor';


function App() {
  return (
    <Router>
      <Navbar/>
      <Routes>
      <Route path='/' element={<Home/>}/>  
      <Route path='/Employee' element={<Employee/>}/>  
      <Route path='/Groups' element={<Grouper/>}/>      
      <Route path='/Supervisor' element={<Supervisor/>}/>      
      </Routes>
      <Footer/>
    </Router>
  );
}

export default App;
