import React from "react";
import "../../assets/css/style.css";
import { Link } from "react-router-dom";
import Button from 'react-bootstrap/Button';
import Modal from 'react-bootstrap/Modal'
import img from '../../assets/images/icons/chevron-down.svg';
import logo from '../../assets/images/icons/logo.svg';


class Header extends React.Component {

  constructor(){
    super();

    this.state = {
       black: true
    }

    
}

changeColor(){
  this.setState({black: !this.state.black})
}



  

  render() {
    let btn_class = this.state.black ? "fa fa-bars " : "fa fa-close ";

    let modal = this.state.black ? "none" : "block";

    

    return (
      <div className="header">
        <div className="mobilelogo-area">
          <Link to={`/`}>
            <img src={logo} />
          </Link>
        </div>

        <div className="top-search">
          
          <i className="fa fa-search"></i>

        </div>

        <div className="topProfile-Menu">

          <Link to={`/`} className="icons notifications">
            <span className="fa fa-bell "></span>
          </Link>

          <div className="icons initials">
            <span>MR</span>
            </div>
            <Link to={`/login`}  style={{ textDecoration: 'none' }}>
            <div className="headerProfile icons">
            <span>Tobi Adeyemi</span>
            <p>tobiadeyemi@abclg.eu</p>
            
            </div>
            
          </Link>

          <Link to={`/login`}  style={{ textDecoration: 'none' }}>
          <img className="icons dropdown" src={img} />
          </Link>
        </div>
        


        <div className="mobile-menu">
          <div className="mobile-top">

          <Link to={`/`} className="m1">
            <span className="fa fa-bell icons" style={{ color: 'var(--font-color1)' }}></span>
          </Link>

          <Link to={`/login`} className="m2"  style={{ textDecoration: 'none' }}>
            <div className="icons">
            <span style={{ color: 'var(--font-color1)' }}>Tobi Adeyemi</span>
            <p style={{ color: 'var(--font-color1)' }}>tobiadeyemi@abclg.eu</p>
            
            </div>
            
          </Link>
          
          
         <i  className={btn_class}  onClick={this.changeColor.bind(this)}></i>
         </div>
         {/* <i className="fa fa-close open-nav"></i> */}

         <div className="open-menu" style={{display: `${modal}`}} >

           <i style={{ color: 'var(--font-color1)' }} className={btn_class} onClick={this.changeColor.bind(this)}></i>

           <ul className="m-Menu">
           <li >
             <Link to={`/`} style={{ color: 'var(--font-color1)' }}>Home </Link>
             </li>
             <li >
             <Link to={`/profile`} style={{ color: 'var(--font-color1)' }}>My Profile </Link>
             </li>
             <li>
             <Link to={`/benefits`} style={{ color: 'var(--font-color1)' }}>My Benefits </Link>
             </li>
             <li>
             <Link to={`/persons`} style={{ color: 'var(--font-color1)' }}>Persons </Link>
             </li>
             <li>
               <Link to={`/invoices`} style={{ color: 'var(--font-color1)' }}>Invoices </Link>
               </li>


           </ul>

           <div className="mobileMenu-footer">
           <label class="switch">
            <input type="checkbox" />
            <span class="slider round"></span>
          </label>
           </div>

           
           
         </div>

        </div>
      </div>
    );
    
  }
}

export default Header;
