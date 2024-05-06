import logo from './logo.svg';
import './App.css';
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import { Footer, Navbar } from './Components';
import { Employee, Home,Grouper, About } from './Pages';
import Supervisor from './Components/Supervisor/Supervisor';
import Evaluate from './Pages/Evaluation/Evaluate';


function App() {
  return (
    <Router>
      <Navbar/>
      <Routes>
      <Route path='/' element={<Home/>}/>  
      <Route path='/Employee' element={<Employee/>}/>  
      <Route path='/Groups' element={<Grouper/>}/>      
      <Route path='/Supervisor' element={<Supervisor/>}/>      
      <Route path='/Evaluation' element={<Evaluate/>}/>      
      <Route path='/About' element={<About/>}/>      
      
      
      </Routes>
      <Footer/>
    </Router>
  );
}

export default App;
