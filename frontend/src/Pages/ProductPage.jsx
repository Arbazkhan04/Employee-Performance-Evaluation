import React from 'react'
import axios from 'axios'
import { Link } from 'react-router-dom';
import { useState, useEffect } from 'react';
import AllProducts from "../components/Products/AllProducts/AllProducts.jsx"

const ProductPage = () => {
 
 const products =[
  {
      "_id": "651812e91209fa9e1fadc8a7",
      "name": "WEB DEVELOPMENT",
      "description": "From ASP.NET to MERN/MEAN stacks, we excel in both backend and frontend development, transforming your ideas into exceptional digital solutions.",
      "price": 12,
      "rating": 0,
      "images": [
          {
              "public_id": "1",
              "url": "https://www.nita.edu.sa/images/thumbs/0001200_web-development-beginner.jpeg",
              "_id": "651812e91209fa9e1fadc8a8"
          }
      ],
      "category": "WEBSITE",
      "PersonAvaliable": 12,
      "numOfReviews": 0,
      "reviews": [],
      "createdAt": "2023-09-30T12:22:01.865Z",
      "__v": 0
  },
  {
      "_id": "651813c51209fa9e1fadc8ab",
      "name": "APP DEVELOPMENT",
      "description": "Pioneering the future of mobile technology, our app development expertise brings innovation and functionality to your fingertips.",
      "price": 12,
      "rating": 0,
      "images": [
          {
              "public_id": "2",
              "url": "https://www.pngmart.com/files/Android-App-Development-PNG-Transparent.png",
              "_id": "651813c51209fa9e1fadc8ac"
          }
      ],
      "category": "DEVELOPMENT",
      "PersonAvaliable": 12,
      "numOfReviews": 0,
      "reviews": [],
      "createdAt": "2023-09-30T12:25:41.327Z",
      "__v": 0
  },
  {
      "_id": "651814c71209fa9e1fadc8af",
      "name": "GRAPHIC DESIGN",
      "description": "From logos to stunning visuals, our graphic design experts craft compelling, eye-catching solutions that leave a lasting impression.",
      "price": 12,
      "rating": 0,
      "images": [
          {
              "public_id": "2",
              "url": "https://www.zilliondesigns.com/blog/wp-content/uploads/creative-graphic-designer.png",
              "_id": "651814c71209fa9e1fadc8b0"
          }
      ],
      "category": "DESIGNS",
      "PersonAvaliable": 6,
      "numOfReviews": 0,
      "reviews": [],
      "createdAt": "2023-09-30T12:29:59.865Z",
      "__v": 0
  }
]
  return (
    <div>
      loading?:():(<AllProducts products={products}/>)
    
    </div>

  )
}

export default ProductPage