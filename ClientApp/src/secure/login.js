import React from "react";
import "../assets/css/login.css";
import Button from "react-bootstrap/Button";
import { Link } from "react-router-dom";

class Login extends React.Component {
  render() {
    return (
      <div>
        <div className="login-box">
          <div className="grid">
            <img
              className="logo"
              src="https://stage.panel.abclg.eu/Images/abc_logo_default.svg"
            />
            {/* <h2 >Sign Up</h2> */}

            <form action="" method="post" className="loginForm">
              <div className="form-group">
                <input
                  type="email"
                  className="loginInput form-control"
                  placeholder="info@mailaddress.com"
                />
              </div>

              <div className="form-group">
                <input
                  type="password"
                  className="loginInput form-control"
                  placeholder="Password"
                />
              </div>

              <div className="form-group">
                <Button variant="outline-dark" type="submit">Sign In</Button>
              </div>

              <div className="form-group">
                <div className="login-btns">
                  <Button variant="outline-secondary">Forgot Password</Button>

                  <Link to={`/register`}>
                  <Button variant="outline-primary" className="btnRegister">  Sign Up</Button>
                  </Link>
                  
                </div>
              </div>
            </form>
          </div>
        </div>
      </div>
    );
  }
}

export default Login;
