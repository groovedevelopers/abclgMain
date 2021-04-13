import React from "react";
import "../assets/css/style.css";
import Sidebar from "./components/sidebar";
import Header from "./components/header";
import Container from "react-bootstrap/Container";
import Table from "react-bootstrap/Table";
import Button from "react-bootstrap/Button";

class Invoices extends React.Component {
  render() {
    return (
      <div>
        <div className="body">
          <Sidebar />

          <div className="pageArea">
            <Header />

            <div className="body-main">
              <Container className="benefits">
                <h1>Invoices</h1>

              
                <Table responsive="xl">
                  <thead>
                    <tr>
                      <th>#</th>
                      <th>Date Issued</th>
                      <th>Payment Due Date</th>
                      <th>Payment Date</th>
                      <th>Other</th>
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
                          <i className="fa fa-download"></i> Download
                        </Button>
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

export default Invoices;
