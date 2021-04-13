import React from "react";
import "../assets/css/style.css";
import Sidebar from "./components/sidebar";
import Header from "./components/header";
import Jumbotron from "react-bootstrap/Jumbotron";
// import Carousel from "react-bootstrap/Carousel";
import Container from "react-bootstrap/Container";
import { Col, Row } from "react-bootstrap";
import Table from "react-bootstrap/Table";
// import Row from "react-bootstrap/Row";
// import Col from "react-bootstrap/Col";
// import Table from "react-bootstrap/Table";
// import Button from "react-bootstrap/Button";

class Profile extends React.Component {
  render() {
    return (
      <div>
        <div className="body">
          <Sidebar />

          <div className="pageArea">
            <Header />

            <div className="hero-banner">
              <Jumbotron
                fluid
                className="Jumbotron"
                style={{
                  backgroundImage:
                    "url('https://res-3.cloudinary.com/crunchbase-production/image/upload/c_lpad,f_auto,q_auto:eco/hf5ux0mbzphyzngj2h7j')",
                }}
              >
                <Container>
                  <img
                    class="profileImg"
                    src="http://assets.stickpng.com/images/585e4bf3cb11b227491c339a.png"
                  />
                  <span class="username">John &nbsp; Doe</span>
                  <br />
                  <span class="position">Abcl sp.zoo.</span>
                </Container>
              </Jumbotron>
            </div>

            <Container className="main">
              <Row>
                <Col>
                  <Table className="profileTable1">
                    <thead>
                      <tr>
                        <th>Email</th>
                        <th>Address</th>
                        <th>
                          <span className="fa fa-pencil "></span>
                        </th>
                      </tr>
                    </thead>
                    <tbody>
                      <tr>
                        <td>1</td>
                        <td>Mark</td>
                      </tr>
                    </tbody>
                  </Table>
                </Col>

                <Col>
                  <Table>
                    <thead>
                      <tr>
                        <th>Telephone</th>
                        <th>Pesel</th>
                        <th>
                          <span className="fa fa-pencil "></span>
                        </th>
                      </tr>
                    </thead>
                    <tbody>
                      <tr>
                        <td>1</td>
                        <td>Mark</td>
                      </tr>
                    </tbody>
                  </Table>
                </Col>
              </Row>
            </Container>

            <div></div>
          </div>
        </div>
      </div>
    );
  }
}

export default Profile;
