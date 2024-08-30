import {} from "react";
import Container from "react-bootstrap/Container";
import Nav from "react-bootstrap/Nav";
import Navbar from "react-bootstrap/Navbar";
import Styles from "../assets/Styles/Navbar.module.css";
import "bootstrap/dist/css/bootstrap.min.css";
import Theme from "./Theme";

function MyNavbar() {
  return (
    <Navbar expand="lg" className={` ${Styles.header}`}>
      <Container className={Styles.content}>
        <Navbar.Brand
          href="#home"
          className={Styles.brand}
          style={{ color: "#fff" }}
        >
          <Nav.Link href="/" className={Styles.navLink}>
            Don
          </Nav.Link>
        </Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className={`ms-auto ${Styles.navLinks}`}>
            <Nav.Link href="/" className={Styles.navLink}>
              Home
            </Nav.Link>
            <Nav.Link href="/resume" className={Styles.navLink}>
              Resume
            </Nav.Link>
            <Nav.Link href="/skills" className={Styles.navLink}>
              Skills
            </Nav.Link>
            <Nav.Link href="/projects" className={Styles.navLink}>
              Projects
            </Nav.Link>
            <Nav.Link href="/testimonials" className={Styles.navLink}>
              Testimonials
            </Nav.Link>
            <Nav.Link href="/contact" className={Styles.navLink}>
              Contact
            </Nav.Link>
          </Nav>
        </Navbar.Collapse>
        <Theme />
      </Container>
    </Navbar>
  );
}

export default MyNavbar;
