# coding-exercise
Hotel deals coding exercise: web application consuming JSON API to retrieve hotel deals using filter criteria. 

Assumptions
- Developed using .Net MVC 3.  So it requires IIS 7 on Windows OS.

Known Issues
- Very simple UI with controls lacking validation

Setup Instructions
- make a new folder (HotelDeals)
- copy the following files and folders from MVCApplication1 folder to HotelDeals folder
  - web.config
  - packages.config
  - Global.asax
  - bin
  - Content
  - Scripts
  - Views
- open IIS 7
- add an application under "Default Web Site"
- name it HotelDeals
- make sure Application pool is ASP.Net v4.0
- specify Physical path to point to HotelDeals folder previously created
- Once setup, the site can be accessed using http://localhost/HotelDeals/
