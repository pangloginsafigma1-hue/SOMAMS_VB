# SOMAMS - Presentation & Defense Guide

## 1. Before you present (10-minute checklist)
- [ ] MySQL service is running; open MySQL Workbench and confirm `somams_db` has data (`SELECT * FROM members;`).
- [ ] Load the demo data (`Database/02_demo_data.sql`) so the screens are not empty.
- [ ] Open the project in Visual Studio, **Build > Rebuild Solution**, press **F5** once to confirm login works.
- [ ] Fill `SmtpAppPassword` in `somams.config.ini` if you will demo "Forgot password" (check that the admin's e-mail in *Settings* is one you can open).
- [ ] Close Word windows. Choose an easy-to-find save folder (Desktop) for the export demo.
- [ ] Set Windows to the projector's resolution *before* starting the app (pages shrink to fit, but start it after).
- [ ] Have a backup: screenshots of each page, and the `.docx` files you exported earlier.

## 2. Suggested 6-minute demo
| # | Show | Say |
|---|---|---|
| 1 | **Login** with wrong password, then `admin / admin123` | "Passwords are BCrypt-hashed. Wrong logins are rejected." |
| 2 | **Dashboard** | "Counts and upcoming activities come straight from MySQL." |
| 3 | **Members** > search a name > **Add** a new member > save | "Every action goes View > Controller > Database (MVC). Duplicate IDs are blocked." |
| 4 | **Edit** that member (ID is locked) > change position | "The ID is the primary key, so it cannot be changed." |
| 5 | **Activities** > add an activity > edit it | "Status is Upcoming / Ongoing / Completed / Cancelled." |
| 6 | **Attendance** > choose an activity > tick a few > **Save** | "The counter updates live; records are saved in one database transaction." |
| 7 | **Reports** > *Members* > Export > open the Word file | "A real Word table is produced; Word does not need to be installed." |
| 8 | **Reports** > *Active and Inactive* > filter by Status = Inactive > Export | "Filters are optional and combine." |
| 9 | **Settings** > change name / photo | "Profile and password can be updated." |
| 10 | **Logout** | "Confirmation, progress, then back to login." |

## 3. Likely questions and short answers
**Why MVC?** It separates screens (Views) from rules/SQL (Controllers) and data shapes (Models), so changing a form does not break the database code and each part is easier to test and explain.

**How are passwords protected?** BCrypt hashing with a salt; the plain password is never stored. Database and e-mail passwords are kept in a separate settings file, not in the source code.

**How do you prevent SQL injection?** Every query uses parameters (`@name` values) instead of joining user text into SQL.

**What does the database look like?** `members` (PK member_id), `activities` (PK activity_id), `attendance` (links one member to one activity; unique pair; foreign keys with ON DELETE CASCADE), and `admins`. One member has many attendance rows; one activity has many attendance rows (a many-to-many relationship resolved by the `attendance` table).

**Why is Membership not a separate table?** Membership details (position, status, date joined) describe the member one-to-one, so they live in `members`; a separate table would only add a join with no benefit.

**What happens when a member is deleted?** Their attendance rows are deleted automatically (foreign key cascade) after a confirmation message.

**How does Word export work?** The Open XML SDK writes a .docx table directly from the data - no Word installation needed. The Members page exports exactly what the grid shows.

**How does "Forgot password" work?** A random 6-digit code is e-mailed (SMTP). It expires in 10 minutes and allows 3 attempts; then the user chooses a new password.

**What if MySQL is stopped?** The login page shows a clear message; errors inside the app show a friendly message instead of crashing.

**What are the limitations / future work?** Single administrator role (no member self-service), no participation/points module yet, no automatic status change when an activity date passes, exports are Word only (PDF/Excel could be added), no audit log.

## 4. If something goes wrong during the defense
| Situation | Do this |
|---|---|
| App cannot connect | Start the MySQL service; check `somams.config.ini`; reopen the app |
| E-mail does not arrive | Check Spam; otherwise show the Forgot-password screens and explain (the code is sent by SMTP) |
| Export dialog hidden behind the window | Alt+Tab to find the Save dialog |
| Screen content cut off | Restart the app after setting the final display resolution |
