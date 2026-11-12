-- Jalankan di MySQL (Workbench / phpMyAdmin / terminal)
CREATE DATABASE IF NOT EXISTS SchoolApp3
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE SchoolApp3;

CREATE TABLE IF NOT EXISTS students (
  id         INT AUTO_INCREMENT PRIMARY KEY,
  nis        VARCHAR(30)  NOT NULL UNIQUE,
  name       VARCHAR(100) NOT NULL,
  class_name VARCHAR(50)  NOT NULL,
  address    VARCHAR(255) NULL
);
