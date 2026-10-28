# SOMAMS - Student Organization Membership and Management System
**College of Computer Studies** | VB.NET (WinForms, .NET 10) | MySQL | MVC architecture

SOMAMS lets an organization's administrator manage members, activities, attendance and reports from one desktop application.

## Features
| Module | What it does |
|---|---|
| **Login** | Secure sign-in (BCrypt-hashed passwords), "Remember me", forgot-password by e-mail verification code |
| **Dashboard** | Live member / activity counts, list of upcoming activities, quick-access links |
| **Members** | Search, add, edit, delete members; export the table to Word |
| **Membership** | Form for a member's ID, name, course, year level, position, status and date joined |
| **Activities** | Create, edit, delete and search organization events |
| **Attendance** | Pick an activity, tick who was present, save; live Present / Absent counter |
| **Reports** | Export to Word: all members, filtered members (by member / position / status), activities by date range, attendance per activity |
| **Settings** | Update profile, profile photo and password |

## Architecture (MVC)
```
View  (Forms/)         what the user sees; only calls Controllers
  |
Controller (Controllers/)   all rules + SQL (parameterized queries)
  |
Model (Models/)        plain data classes: Admin, Member, Activity, AttendanceRecord
  |
MySQL  (Database/)     4 tables: admins, members, activities, attendance
```
Helpers (`Helpers/`): `Database` (connection), `AppConfig` (reads settings file), `Theme` (one look for every form), `Navigator` (page switching + sidebar), `WordExporter` (tables to .docx), `EmailService`, `UiHelper`, `Lookups`, `Session`.

```
SOMAMS/
  Database/            01_schema.sql, 02_demo_data.sql
  SOMAMS/
    Controllers/  Forms/  Helpers/  Models/  Resources/
    somams.config.ini  (your private settings)
    SOMAMS.vbproj
```

## Setup (first time)
**You need:** Visual Studio with the ".NET desktop development" workload (.NET 10), and MySQL Server 8 + MySQL Workbench.

1. **Create the database** - MySQL Workbench > open your connection > *File > Open SQL Script* > `Database/01_schema.sql` > click the lightning bolt.
2. **(Optional) load sample data for the demo** - run `Database/02_demo_data.sql` the same way.
3. **Set your login details** - open `SOMAMS/somams.config.ini` and make sure `DbUser` / `DbPassword` match your MySQL Workbench connection.
4. **(Optional) e-mail for "Forgot password"** - in the same file fill `SmtpUser` and `SmtpAppPassword` (a Google *App Password*, not your normal password).
5. Open `SOMAMS.slnx` in Visual Studio, press **F5**.
6. Log in with **admin / admin123**, then change the password in *Settings*.

> The settings file is copied next to `SOMAMS.exe` on every build. If you run the `.exe` on another computer, copy `somams.config.ini` with it.

## Troubleshooting
| Message / problem | Fix |
|---|---|
| "SOMAMS cannot connect to the MySQL database" | Start the MySQL service (Windows > Services > MySQL80); check `somams.config.ini` |
| "The database has not been set up yet" | Run `Database/01_schema.sql` |
| `Access denied for user 'root'` | Wrong `DbPassword` in `somams.config.ini` |
| "Forgot password" says e-mail is not set up | Fill `SmtpUser` and `SmtpAppPassword` in `somams.config.ini` |
| Page looks too big on a small screen | Nothing to do: pages shrink to fit automatically |
| Word export says file is in use | Close the .docx in Word and export again |

## Security notes
- Passwords are stored as BCrypt hashes; all SQL uses parameters (no SQL injection).
- Database and e-mail passwords live only in `somams.config.ini`, which `.gitignore` excludes from Git.
- Forgot-password codes are random 6-digit numbers that expire after 10 minutes and allow 3 attempts.
