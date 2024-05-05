// components/Navbar/index.js

import React from "react";
import {
    Nav,
    NavLink,
    Bars,
    NavMenu,
    NavBtn,
    NavBtnLink,
} from "./navbarElement";

const Navbar = () => {
    return (
        <>
            <Nav>
                <Bars />
                <h1> 
                <NavLink to="/" >
                       EPE
                    </NavLink>
                </h1>
                <NavMenu>
                    <NavLink to="/about" >
                        About
                    </NavLink>
                    <NavLink to="/Supervisor" activeStyle>
                        Supervisor
                    </NavLink>
                    <NavLink to="/HR_Report" activeStyle>
                        HR Report
                    </NavLink>
                    <NavLink to="/Employee" activeStyle>
                        Employee
                    </NavLink>
                    <NavLink to="/Groups" activeStyle>
                        Groups
                    </NavLink>
                    <NavLink to="/Evaluation" activeStyle>
                        Evaluation
                    </NavLink>
                    {/* Second Nav */}
                    {/* <NavBtnLink to='/sign-in'>Sign In</NavBtnLink> */}
                </NavMenu>
                <NavBtn>
                    <NavBtnLink to="/signin">
                        Sign In
                    </NavBtnLink>
                </NavBtn>
            </Nav>
        </>
    );
};

export default Navbar;
