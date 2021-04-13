import React from "react";
import "../../assets/css/style.css";

class HeaderM extends React.Component {
  render() {
    return (
        <div className="mobileMenu">

          {/* Logo Area */}
          <div className="mobile-logo">
            <a href="/">
              <img src="https://stage.panel.abclg.eu/Images/abc_logo_default.svg" />
            </a>
          </div>

          {/* Logo Area Ends */}

        </div>

        
        
    );
  }
}

export default HeaderM;
