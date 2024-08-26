import "./App.css";
import Contact from "./Components/Contact";
import LandingPage from "./Components/LandingPage";
import MyNavbar from "./Components/Navbar";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Skills from "./Components/Skills";
import Resume from "./Components/Resume";
import Testimonials from "./Components/Testimonials";
import Projects from "./Components/Project";

function App() {
  return (
    <>
      <Router>
        <MyNavbar />
        <Routes>
          <Route path="/" element={<LandingPage />} />
          <Route path="/Contact" element={<Contact />} />
          <Route path="/Skills" element={<Skills />} />
          <Route path="/Resume" element={<Resume />} />
          <Route path="/testimonials" element={<Testimonials />} />
          <Route path="/projects" element={<Projects />} />
        </Routes>
      </Router>
    </>
  );
}

export default App;
