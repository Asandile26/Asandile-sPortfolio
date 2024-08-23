import { useState, useEffect } from "react";
import Card from "react-bootstrap/Card";
import { projectEndpoint } from "./EndPoints/EndPoint";
import axios from "axios";
import styles from "./assets/Styles/Project.module.css";

interface Project {
  name: string;
  gitHub: string;
  netlify: string;
  image: string;
}

function Projects() {
  const [projects, setProjects] = useState<Project[]>([]);

  useEffect(() => {
    axios
      .get<Project[]>(`${projectEndpoint}`)
      .then((response) => {
        if (Array.isArray(response.data)) {
          console.log(response.data);
          setProjects(response.data);
        } else {
          console.error(
            "Expected an array of testimonials but received:",
            response.data
          );
        }
      })
      .catch((error) => {
        console.error("Error fetching testimonials:", error);
      });
  }, []);

  return (
    <div className={`container ${styles.projectPage}`}>
      {projects.map((projects, index) => (
        <Card key={index} style={{ width: "18rem", margin: "10px" }}>
          <Card.Img
            variant="top"
            src={projects.image}
            alt={projects.name}
            className={styles.top}
          />
          <Card.Body>
            <Card.Title>{projects.name}</Card.Title>
          </Card.Body>
          <Card.Body>
            <Card.Link href={projects.gitHub} target="_blank">
              <button className={styles.links}>GithubLink</button>
            </Card.Link>
            <Card.Link href={projects.gitHub} target="_blank">
              <button className={styles.links}>NetlifyLink</button>
            </Card.Link>
          </Card.Body>
        </Card>
      ))}
    </div>
  );
}

export default Projects;
