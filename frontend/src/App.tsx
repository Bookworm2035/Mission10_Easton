import React, { useState } from 'react';
// import logo from './logo.svg';
import './App.css';
import movieData from './MovieData.json';
import Header from './Header';
import BowlerList from './Bowling/BowlerList';

const MovieDataSample = movieData.MovieDataBlah;

// function GoButton(props: any) {
//   return (
//     <div>
//       <button onClick={props.onClickFunctionBlah}>Go!</button>
//       <br></br>
//     </div>
//   );
// }
// function GoLevel(props: any) {
//   return <label>Amount of Go: {props.numToShow}</label>;
// }
function Welcome() {
  return <h1>Hey welcome friend</h1>;
}
// function Footer() {
//   return <footer>Come back again</footer>;
// }
// function Content() {
//   return (
//     <>
//       <p>Here is a random number</p>
//       <br />
//       <h3>{Math.random()}</h3>
//     </>
//   );
// }

function movieList() {
  return (
    <>
      <h3>Movie Collection List</h3>
      <table className="table">
        <thead>
          <tr>
            <th>Title</th>
            <th>Year</th>
            <th>Director</th>
            <th>Rating</th>
            <th>Category</th>
          </tr>
        </thead>
        <tbody>
          {MovieDataSample.map((m) => (
            <tr>
              <td>{m.Title}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}
function App() {
  const [levelOfGo, updateLevel] = useState(1);
  const incrementGo = () => updateLevel(levelOfGo * 2);

  return (
    <div className="App">
      <Header />
      <BowlerList />
      {/* <Welcome />
      {/* <Content />
      <Footer /> 
      <GoButton onClickFunctionBlah={incrementGo} />
      <GoLevel numToShow={levelOfGo} /> */}
    </div>
  );
}

export default App;
