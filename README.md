
# Hostel Management System (WinForms)

This Visual Studio project is a Windows Forms application for managing hostel operations: students, staff, rooms, fines, CSV import/export, and admin authentication.

## Quick start
- Open `HostelManagementSystem.csproj` in Visual Studio 2019/2022.
- Build and run. Default admin password: **admin**.
- Admin can change password in the login window.
- Data persisted to `hostel_data.xml` in application folder.

## Features
- Student/Staff CRUD
- Room assignment
- Fine tracking (mark paid/remove)
- CSV export/import for students
- Admin authentication (SHA256 hashed password stored in XML)
