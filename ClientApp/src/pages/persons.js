import React from "react";
import "../assets/css/style.css";
import Sidebar from "./components/sidebar";
import Header from "./components/header";
import Container from "react-bootstrap/Container";
import Table from "react-bootstrap/Table";
import Button from "react-bootstrap/Button";

class Persons extends React.Component {
  render() {
    return (
      <div>
        <div className="body">
          <Sidebar />

          <div className="pageArea">
            <Header />

            <div className="body-main">
              <Container className="benefits">
                <h1>Persons</h1>

                <div className="btn-right">
                  
                  <Button variant="outline-secondary">
                    {" "}
                    <i className="fa fa-user"></i> Add Persons
                  </Button>
                </div>
                <Table responsive="xl">
                  <thead>
                    <tr>
                      <th>Name</th>
                      <th>Correlation type</th>
                      <th>Id</th>
                      <th>Benefits</th>
                      <th>Address</th>
                      <th>Phone</th>
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
                      <td>@mdo</td>
                      <td>
                        <Button variant="outline-dark">
                          <i className="fa fa-edit"></i> Edit
                        </Button>
                        &nbsp;
                        <Button variant="outline-danger">Delete</Button>
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

export default Persons;
