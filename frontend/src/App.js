import React from 'react'
import "./App.css"
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import {Footer} from "./containers";
import {Navbar,Group, Supervisor} from "./components";
import Home from './Pages/Home';
import Membership from './components/membership/membership.jsx';
import Evaluate from './components/Evaluate/Evaluate.jsx';


function App() {
  return (
    <Router>
      <Navbar/>
      <Routes>
        <Route path='/' element={<Home/>}/>  
        <Route path='/groups' element={<Group/>}/>
        <Route path='/evaluation' element={<Evaluate/>}/>
        <Route path='/supervisor' element={<Supervisor/>}/>
        <Route path='/membership/apply' element={<Membership/>}/>
      </Routes>
      <Footer/>
    </Router>
  );
}

export default App;
