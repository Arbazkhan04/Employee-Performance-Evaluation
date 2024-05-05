import logo from './logo.svg';
import './App.css';
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import { Footer, Navbar } from './Components';

function App() {
  return (
    <Router>
      <Navbar/>
      <Routes>
      </Routes>
      <Footer/>
    </Router>
  );
}

export default App;
