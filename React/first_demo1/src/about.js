import React, { Component } from "react";
import "bootstrap/dist/css/bootstrap.min.css";

class About extends Component {
  render() {
    return (
      <div className="container mt-4" data-testid="about-content">
        <div className="card">
          <img src="banner-image.jpg" className="card-img-top" alt="About Us Banner" />
          <div className="card-body">
            <h2 className="card-title">About Us</h2>
            <p className="card-text">
              Lorem Ipsum is simply dummy text of the printing and typesetting industry.
              It has been the industry's standard dummy text since the 1500s.
            </p>
          </div>
        </div>
      </div>
    );
  }
}

export default About;
