import React, { useState } from 'react';
import axios from 'axios';
import './Books.css';


function App() {
  const [data, setData] = useState({})
  const [search, Seatsearch] = useState('')
  //const url = `https://api.openweathermap.org/data/2.5/weather?q=${location}&units=imperial&appid=895284fb2d2c50a520ea537456963d9c`

  
  const url = `https://localhost:7228/api/Books/GetAllLibraryBooks?BooksNames=${search}`
  
  


  const searchLocation = (event) => {
    if (event.key === 'Enter') {
      axios.get(url).then((response) => {
        setData(response.data)
        console.log(response.data)
      })
      //setLocation('')
    }
  }
  return (
    <div className="app">
      <h1 class="My">Find Your Book </h1>
     <div class="img"></div>
     <img class="img1" src="https://i.pinimg.com/736x/d3/68/b1/d368b11f043561a239278a22f4f1c75d--cartoon-inspirational.jpg" alt="Book"></img>
    
      <div className="search">
        <input
          value={search}
          onChange={event => Seatsearch(event.target.value)}
          onKeyPress={searchLocation}
          placeholder='Enter Book name'
            type="text" />
      </div>
      <div className="container">
        <div className="top">
          <div className="location"> 
                  
            <p> BookName : {data.bookName}</p>
          </div>
          <div className="temp">
            <p class="Auth">Author Name : {data.author}</p>
          </div>
          <div className="PublishedDate">
           <p class="Date">PublishedDate : {data.piblishedDate}</p>
          </div>
          <div className="bottom">
          <div className="a3">
           <p className="Price">Price$ : { data.price }</p>
          </div>
          <div className="a2">
           <p className="url" ><img src={data.urlLink} alt={data.Tittle} /></p>
          </div>
          <div className="a1">
           <p className="des" >Description : {data.descriptions}</p>
          </div>
          </div>
          <button class="b"><a href='https://manybooks.net/'>Order  </a></button>
          
          
        </div>
                    
        </div>

        
      </div>
    

    
  );
}
export default App;