<<<<<<< HEAD
import React from 'react'
import "./App.css"
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import {Footer} from "./containers";
import {Navbar,Group, Supervisor} from "./components";
import Home from './Pages/Home';
import Membership from './components/membership/membership.jsx';
import Evaluate from './components/Evaluate/Evaluate.jsx';
=======
import logo from './logo.svg';
import './App.css';
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import { Footer, Navbar } from './Components';
import { Employee, Home,Grouper, About } from './Pages';
import Supervisor from './Components/Supervisor/Supervisor';
import Evaluate from './Pages/Evaluation/Evaluate';
>>>>>>> featwebSignIn


function App() {
  return (
    <Router>
      <Navbar/>
      <Routes>
<<<<<<< HEAD
        <Route path='/' element={<Home/>}/>  
        <Route path='/groups' element={<Group/>}/>
        <Route path='/evaluation' element={<Evaluate/>}/>
        <Route path='/supervisor' element={<Supervisor/>}/>
        <Route path='/membership/apply' element={<Membership/>}/>
=======
      <Route path='/' element={<Home/>}/>  
      <Route path='/Employee' element={<Employee/>}/>  
      <Route path='/Groups' element={<Grouper/>}/>      
      <Route path='/Supervisor' element={<Supervisor/>}/>      
      <Route path='/Evaluation' element={<Evaluate/>}/>      
      <Route path='/About' element={<About/>}/>      
      
      
>>>>>>> featwebSignIn
      </Routes>
      <Footer/>
    </Router>
  );
}

export default App;
