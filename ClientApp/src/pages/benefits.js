import React from "react";
import "../assets/css/style.css";
import Sidebar from "./components/sidebar";
import Header from "./components/header";
import Container from "react-bootstrap/Container";
import Table from "react-bootstrap/Table";
import Button from "react-bootstrap/Button";

class Benefits extends React.Component {
  render() {
    return (
      <div>
        <div className="body">
          <Sidebar />

          <div className="pageArea">
            <Header />

            <div className="body-main">
              <Container className="benefits">
                <h1>Your Benefits</h1>

                <div className="btn-right ">
                  <Button variant="outline-primary">
                    
                    <i className="fa fa-plus"></i> Add Benefits
                  </Button>
                  &nbsp; &nbsp;
                  <Button variant="outline-secondary">
                    
                    <i className="fa fa-user"></i> Add Persons
                  </Button>
                </div>
                <Table responsive="xl">
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
                        <Button variant="outline-dark">
                          <i className="fa fa-edit"></i> Edit
                        </Button>
                        &nbsp;
                        <Button variant="outline-danger">Deactivate</Button>
                      </td>
                    </tr>
                  </tbody>
                </Table>
              </Container>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

export default Benefits;
