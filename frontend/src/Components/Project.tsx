import { useState, useEffect } from "react";
import Card from "react-bootstrap/Card";
import Spinner from "react-bootstrap/Spinner";
import axios from "axios";
import { projectEndpoint } from "../EndPoints/EndPoint";
import styles from "../assets/Styles/Project.module.css";

interface Project {
  name: string;
  gitHub: string;
  netlify: string;
  image: string;
}

function Projects() {
  const [projects, setProjects] = useState<Project[]>([]);
  const [loading, setLoading] = useState(true); // Add loading state

  useEffect(() => {
    axios
      .get<Project[]>(`${projectEndpoint}`)
      .then((response) => {
        if (Array.isArray(response.data)) {
          setProjects(response.data);
        } else {
          console.error(
            "Expected an array of projects but received:",
            response.data
          );
        }
      })
      .catch((error) => {
        console.error("Error fetching projects:", error);
      })
      .finally(() => setLoading(false)); // Set loading to false after data is fetched
  }, []);

  return (
    <div className={`container ${styles.projectPage}`}>
      <h3 className={styles.heading}>Projects</h3>

      {/* Display Spinner while loading */}
      {loading ? (
        <div className="text-center" style={{ marginTop: "15rem" }}>
          <Spinner animation="border" role="status">
            <span className="visually-hidden">Loading...</span>
          </Spinner>
        </div>
      ) : (
        projects.map((project, index) => (
          <Card key={index} style={{ width: "18rem", margin: "10px" }}>
            <Card.Img
              variant="top"
              src={project.image}
              alt={project.name}
              className={styles.top}
            />
            <Card.Body>
              <Card.Title>{project.name}</Card.Title>
            </Card.Body>
            <Card.Body>
              <Card.Link href={project.gitHub} target="_blank">
                <button className={styles.links}>GithubLink</button>
              </Card.Link>
              <Card.Link href={project.netlify} target="_blank">
                <button className={styles.links}>NetlifyLink</button>
              </Card.Link>
            </Card.Body>
          </Card>
        ))
      )}
    </div>
  );
}

export default Projects;
