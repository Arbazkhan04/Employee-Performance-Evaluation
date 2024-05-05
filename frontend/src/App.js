import logo from './logo.svg';
import './App.css';
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import { Footer, Navbar } from './Components';
import { Employee, Home } from './Pages';

function App() {
  return (
    <Router>
      <Navbar/>
      <Routes>
      <Route path='/' element={<Home/>}/>  
      <Route path='/Employee' element={<Employee/>}/>  
          
      </Routes>
      <Footer/>
    </Router>
  );
}

export default App;
