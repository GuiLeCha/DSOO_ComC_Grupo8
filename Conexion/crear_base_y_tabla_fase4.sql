CREATE DATABASE club_deportivo;
USE club_deportivo;

CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL,
    clave VARCHAR(50) NOT NULL
);

INSERT INTO usuarios (usuario, clave) VALUES
('admin', '1234');