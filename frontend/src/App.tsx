import "./App.css";
import Contact from "./Contact";
import LandingPage from "./LandingPage";
import MyNavbar from "./Navbar";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Skills from "./Skills";
import Resume from "./Resume";
import Testimonials from "./Testimonials";
import Projects from "./Project";

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
