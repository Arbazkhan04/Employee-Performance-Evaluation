import React, { useState } from 'react'
import "./navbar.css"
import logo from "../../assets/logo.png"
import { RiMenu3Line, RiCloseLine } from "react-icons/ri"
import { Link } from 'react-router-dom';

const Menu = () => (
  <>
    <p><Link to={'/'}>Home</Link></p>
    <p><Link to={'/department'}>Department</Link></p>
    <p><Link to={'/all'}>View All</Link></p>
    <p><Link to={'/evaluation'}>Evaluation</Link></p>
    <p><Link to={'/supervisor'}>Supervisor</Link></p>
    <p><Link to={'/groups'}>Groups</Link></p>
    <p><Link to={'/membership/apply'}>Employee</Link></p>
  </>
)

const Navbar = () => {
  const [toggleMenu, setToggleMenu] = useState(false)
  return (
    <div className="woix__navbar">
      <div className="woix__navbar-links">
        <div className="woix__navbar-links_logo">
          <Link to={'/'}><img src={logo} alt="EPE Logo"/></Link>
        </div>
        <div className="woix__navbar-links_container">
          <Menu />
        </div>
        <div className="woix__navbar-wrapper">
          
          {/* Responsive part for mobiles devices */}
          {/* hamburger menu */}
          <div className="woix__navbar-menu">
            {toggleMenu
              ? <RiCloseLine color="#fff" size={27} onClick={() => setToggleMenu(false)} />
              : <RiMenu3Line color="#fff" size={27} onClick={() => setToggleMenu(true)} />
            }
            {toggleMenu &&
              <div className="woix__navbar-menu_container scale-up-center">
                <div className="woix__navbar-menu_container-links">
                  <Menu />
                </div>
              </div>
            }
          </div>
        </div>
      </div>
    </div>
  )
}

export default Navbar