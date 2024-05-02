import React from 'react'
import "./footer.css"
import logoUrl from "../../assets/logo.png"

const Footer = () => {
  return (
    <div className="woix__footer section__padding">
      <div className="woix__footer-heading">
        <h1 className="gradient__text">
          Do you want to step in to the future before others?
        </h1>
      </div>
      <div className="woix__footer-links">
        <div className="woix__footer-links_logo">
          <img src={logoUrl} alt="EPE logo" />
          <p>GT Road Lahore Pakistan</p>
        </div>
        <div className="woix__footer-links_div">
          <h4>Links</h4>
          <p>Overons</p>
          <p>Social Media</p>
          <p>Counters</p>
          <p>Contact</p>
        </div>
        <div className="woix__footer-links_div">
          <h4>Company</h4>
          <p>Terms & Conditions</p>
          <p>Privacy Policy</p>
          <p>Contact</p>
        </div>
        <div className="woix__footer-links_div">
          <h4>Get in touch</h4>
          <p>GT Road Lahore Pakistan</p>
          <p>0309-8273508</p>
          <p>woixinstitute@gmail.com</p>
        </div>
      </div>
      <div className="woix__footer-copyrights">
        ©2023 EPE. All rights reserved.
      </div>
    </div>
  )
}

export default Footer