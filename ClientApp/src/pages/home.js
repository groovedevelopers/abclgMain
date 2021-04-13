import React from "react";
import "../assets/css/style.css";
import Sidebar from "./components/sidebar";
import Header from "./components/header";
import Carousel from "react-bootstrap/Carousel";
import Container from "react-bootstrap/Container";
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import Table from 'react-bootstrap/Table';
import Button from 'react-bootstrap/Button';

class Home extends React.Component {
  constructor(props, context) {
    super(props, context);

    this.handleSelect = this.handleSelect.bind(this);

    this.state = {
      index: 0,
      direction: null,
    };
  }

  handleSelect(selectedIndex, e) {
    this.setState({
      index: selectedIndex,
      // direction: e.direction,
    });
  }

  render() {
    const { index, direction } = this.state;
    return (
      <div>
        <div className="body">
          <Sidebar />

          <div className="pageArea">
            <Header />

            <Container className="welcome">
            <h1>Welcome Back, <b>Tobi </b></h1>


            </Container>

            <Carousel
              className="sliding-banner"
              activeIndex={index}
              direction={direction}
              onSelect={this.handleSelect}
            >
              <Carousel.Item>
                <img
                  className="d-block w-100"
                  src="https://cdn.pixabay.com/photo/2021/02/12/09/36/sunflowers-6007847__480.jpg"
                  alt="First slide"
                />
                <Carousel.Caption>
                  <h3>First slide label</h3>
                  <p>
                    Nulla vitae elit libero, a pharetra augue mollis interdum.
                  </p>
                </Carousel.Caption>
              </Carousel.Item>
              <Carousel.Item>
                <img
                  className="d-block w-100"
                  src="https://cdn.pixabay.com/photo/2021/02/06/16/29/jay-5988657__480.jpg"
                  alt="Second slide"
                />

                <Carousel.Caption>
                  <h3>Second slide label</h3>
                  <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                  </p>
                </Carousel.Caption>
              </Carousel.Item>
            </Carousel>



            <div className="hero-tables">
            <Container >
  
  <Row>
    <Col className="hero-col1" >
    <h1>Your Benefits</h1>
    <Table  responsive="xl">
  <thead>
    <tr>
      <th>#</th>
      <th>Product</th>
      <th>Staus</th>
      <th>Dates</th>
      <th>Price</th>
      <th>Action</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>1</td>
      <td>Mark</td>
      <td>Otto</td>
      <td>@mdo</td>
      <td>@mdo</td>
      <td>
      <Button variant="outline-dark"><i className="fa fa-edit"></i> </Button>
      &nbsp;
      <Button variant="outline-danger"><i className="fa fa-ban"></i></Button>
      </td>
    </tr>
  </tbody>
</Table>
    </Col>
    <Col className="hero-col2">
    <h1>People and Benefits</h1>
    <Table  responsive="xl">
  <thead>
    <tr>
      <th>#</th>
      <th>First Name</th>
      <th>Last Name</th>
      <th>Username</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>1</td>
      <td>Mark</td>
      <td>Otto</td>
      <td>@mdo</td>
    </tr>
    <tr>
      <td>2</td>
      <td>Jacob</td>
      <td>Thornton</td>
      <td>@fat</td>
    </tr>
    <tr>
      <td>3</td>
      <td colSpan="2">Larry the Bird</td>
      <td>@twitter</td>
    </tr>
  </tbody>
</Table>
    </Col>
  </Row>
</Container>
            </div>
          </div>
        </div>

        
      </div>
    );
  }
}

export default Home;
