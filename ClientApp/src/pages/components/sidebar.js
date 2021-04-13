import React from "react";
import "../../assets/css/style.css";
import logo from "../../assets/images/icons/logo.svg";
import {
  Link
} from "react-router-dom";

class Sidebar extends React.Component {
  render() {
    return (
        // <div>
        <div className="sidebar-menu">
          {/* Logo Area */}
          <div className="logo-area">
          <Link to={`/`}>
              <img src={logo} />
              </Link>
          </div>

          {/* Logo Area Ends */}

          {/* Navbar Starts */}
          <div className="navMenu">

            <Link to={`/profile`}>
              <div className="navMenuList">
                <i className="fa fa-user-circle"> &nbsp; </i> My Profile
              </div>
              </Link>

            <Link to={`/benefits`}>
              <div className="navMenuList">
                <i className="fa fa-gift"> &nbsp; </i> My Benefits
              </div>
              </Link>

            <Link to={`/persons`}>
              <div className="navMenuList">
                <i className="fa fa-user"> &nbsp; </i>Persons
              </div>
              </Link>

            <Link to={`/invoices`}>
              <div className="navMenuList">
                <i className="fa fa-file"> &nbsp; </i> Invoices
              </div>
              </Link>
          </div>

          {/* Navbar Ends */}

          {/* Sidebar Footer Logo */}
          <div className="footer-logo">
            <span>Powered By:</span>
            &nbsp;
            &nbsp;
            
            <img src={logo}
              height="100px"
              width="100px"
            />
          </div>
          {/* Sidebar Footer Logo Ends */}
        </div>

        
        // <div className="mobile-nav">

        // </div>

        
        // </div>
        
    );
  }
}

export default Sidebar;
