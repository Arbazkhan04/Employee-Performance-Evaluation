import React from "react";
import PersonCard from "./PersonCard.jsx";

const AllPersons = ({ persons }) => {
  return (
    <div className='grid sm:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4'>
      {persons.map((item) => (
            <PersonCard person={item}/>
     ))}
    </div>
  );
};

export default AllPersons