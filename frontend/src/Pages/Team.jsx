import React from 'react'
import axios from 'axios'
import { useState, useEffect } from 'react';
import AllPersons from '../components/PersonCard/AllPersons';

const OurTeam = () => {
  const [loading,setLoading] = useState(false);
const workers = [
  {
      "avatar": {
          "public_id": "SAMPLE ID",
          "url": "profileUrl"
      },
      "_id": "6518418a739066240cb875fd",
      "name": "Muhammad Faizan Asim",
      "linkdin": "https://www.linkedin.com/in/muhammad-faizan-asim-3098a9268/",
      "details": "As the visionary force behind Woix, Faizan's remarkable journey as a MERN Stack Developer and Machine Learning Engineer exemplifies innovation at its finest.",
      "works": "CEO",
      "email": "mr.faizan.asim@gmail.com",
      "role": "admin",
      "__v": 0
  },
  {
      "avatar": {
          "public_id": "SAMPLE ID",
          "url": "profileUrl"
      },
      "_id": "65186c7014329850423d1d33",
      "name": "Muhammad Abdul Barr",
      "linkdin": "https://www.linkedin.com/in/muhammad-abdul-barr/",
      "details": " Muhammad Abdul Barr leadership and management skills are the backbone of our organization's success. His tireless efforts have not only elevated our company but also inspired those around him to strive for excellence.",
      "works": "Vice President",
      "email": "barr@gmail.com",
      "role": "admin",
      "__v": 0
  },
  {
      "avatar": {
          "public_id": "SAMPLE ID",
          "url": "profileUrl"
      },
      "_id": "65186e6f14329850423d2285",
      "name": "Abdur Rehman Kazim",
      "linkdin": "https://www.linkedin.com/in/abdur-rehman-kazim-77aa6923b/",
      "details": " I'm a tech enthusiast working to stay ahead of the curve. Continually learning, exploring, and pushing the boundaries of technology with critical thinking and logical reasoning..",
      "works": "MERN STACK DEVELOPER",
      "email": "kkk@gmail.com",
      "role": "admin",
      "__v": 0
  },
  {
    "avatar": {
        "public_id": "SAMPLE ID",
        "url": "profileUrl"
    },
    "_id": "681dbae104e2b5d8e0b7d6be",
    "name": "Afeera Fatima",
    "linkdin": "https://www.linkedin.com/in/afeera-fatima/",
    "details": "Meet the magician named Afeera Fatima, who connects top technical talent with innovative companies",
    "works": "Technical Recruiter",
    "email": "khuramiqbalofficial@gmail.com@gmail.com",
    "role": "admin",
    "__v": 0
  },
  {
      "avatar": {
          "public_id": "SAMPLE ID",
          "url": "profileUrl"
      },
      "_id": "65186f1314329850423d242e",
      "name": "Anas Mustafa ",
      "linkdin": "https://www.linkedin.com/in/anasmus/",
      "details": " Anas transforms pixels into intuitive interfaces, breathing life into digital dreams.",
      "works": "WEB DEVELOPER",
      "email": "aaa@gmail.com",
      "role": "admin",
      "__v": 0
  },
  {
      "avatar": {
          "public_id": "SAMPLE ID",
          "url": "profileUrl"
      },
      "_id": "651dbae104e2b5d8e0b7d6be",
      "name": "Khuram Iqbal",
      "linkdin": "https://www.linkedin.com/in/khuram-iqbal//",
      "details": "Meet the magician named Khuram, who turns posts into conversations and hashtags into trends",
      "works": "Social Media Manager",
      "email": "khuramiqbalofficial@gmail.com@gmail.com",
      "role": "admin",
      "__v": 0
  },
]
  return (
    <div>
    loading?:():(<AllPersons persons={workers}/>)
    </div>
    
  )
}

export default OurTeam