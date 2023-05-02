CREATE DATABASE MyHospitalDB9;

USE MyHospitalDB9;



CREATE TABLE Doctors (
    DoctorId INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(255) NOT NULL,
    Specialization VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    PhoneNumber VARCHAR(20) NOT NULL
);

CREATE TABLE Patients (
    PatientId INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(255) NOT NULL,
    Age INT NOT NULL,
    Gender VARCHAR(10) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    PhoneNumber VARCHAR(20) NOT NULL
);

CREATE TABLE Appointments (
AppointmentId INT NOT NULL AUTO_INCREMENT,
Date DATE NOT NULL,
StartTime TIME NOT NULL,
EndTime TIME NOT NULL,
DoctorId INT NOT NULL,
PatientId INT NOT NULL,
PRIMARY KEY (AppointmentId),
FOREIGN KEY (DoctorId) REFERENCES doctor(DoctorId),
FOREIGN KEY (PatientId) REFERENCES patient(PatientId)
);

INSERT INTO Doctors (Name, Specialization, Email, PhoneNumber)
VALUES ('John Smith', 'Cardiologist', 'john.smith@email.com', '555-1234');

INSERT INTO Patients (Name, Age, Gender, Email, PhoneNumber)
VALUES ('Jane Doe', 35, 'Female', 'jane.doe@email.com', '555-5678');

INSERT INTO Appointments (Date, StartTime, EndTime, DoctorId, PatientId)
VALUES ('2023-04-27', '10:00:00', '10:30:00', 1, 1);