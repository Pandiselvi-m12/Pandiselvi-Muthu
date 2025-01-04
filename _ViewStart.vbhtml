
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>SLA Learners Assessment </title>
   
    <link rel="stylesheet" href="styles.css">
    <style>
        html {
            font-size: 15px;
        }

        body {
            font-family: "Poppins", sans-serif;
            font-size: 5rem;
            background: #222f37;
            color: #d6e0f9;
        }

        body {
            margin: 0px !important;
            font-family: "Poppins", sans-serif;
            font-size: 5rem;
            background: #222f37;
            color: #d6e0f9;
        }

        #background-container {
            width: 100%;
            height: 100%;
            background-size: auto;
        }

        /* top-left text */
        .text-block {
            position: absolute;
            top: 50%;
            left: 10%;
            color: white;
            padding-left: 1px;
            padding-right: 1px;
        }

       
        .navbar {
            width: 100%;
            height:10%;
            position: fixed;
            top: 0;
            left: 0;
            background: #fff;
            display: flex;
            align-items: center;
            justify-content: space-between;
            color: #495ca8;
        }

        .logo {
            width: 90px;
        }

            .logo img {
                width: 100%;
                height:80%;
             
            }

        .menu {
            list-style: none;
        }

            .menu li {
                position: relative;
                float: left;
            }

                .menu li a {
                    font-family: "Poppins", sans-serif;
                    font-size: 1.4rem;
                    color: black;
                    background:#fff;
                    display: block;
                    text-decoration: none;
                    padding: 1rem 1.5rem;
                }

                    .menu li a:hover {
                        background: #495ca8;
                        color: #fff;
                    }
        .logout-button {
            background-color: #495ca8;
            border:double;
            color: white;
            display: flex;
            padding: 0.5rem 1rem;
            cursor: pointer;
           
        }

            .logout-button:hover {
                background-color: #ff1a1a;
            }

        .submenu {
            position: absolute;
            left: 0;
            background: #101d23;
            display: none;
            transition: all .3s ease-in-out;
            padding: 0px !important;
        }

        .submenu-wrapper:hover .submenu,
        .submenu-wrapper:focus-within .submenu {
            display: initial;
        }

        .submenu li {
            width: 100%;
            border-top: .1rem solid #222f37;
            list-style: none;
        }

        .toggle-btn {
            display: none;
            z-index: 1000;
        }

        .icon {
            position: relative;
            width: 5rem;
        
            cursor: pointer;
            z-index: 100;
        }

            .icon::before {
                top: 0;
                right: 0;
                content: '';
                position: absolute;
                width: 2rem;
                
                background-color: #d6e0f9;
                transition: all 0.3s ease-in-out;
            }

            .icon::after {
                bottom: 0;
                right: 0;
                content: '';
                position: absolute;
                width: 1.5rem;
                height: .2rem;
                background-color: #d6e0f9;
                transition: transform 0.3s ease-in-out;
            }

            .icon.active::before {
                width: 1.5rem;
                transform: rotate(-45deg) translate(-0.21rem, 0.21rem);
            }

            .icon.active::after {
                transform: rotate(45deg) translate(-0.21rem, -0.21rem);
            }

       
    </style>

</head>
<body>
    <nav class="navbar">
        <div class="logo">
            <img src="https://miro.medium.com/v2/resize:fit:2400/1*U5zKftoMDJRSPXp7DCGnrw.png">
        </div>
        <div class="toggle-btn">
            <div class="icon"></div>
        </div>
        <ul class="menu">
            <li class="submenu-wrapper">
                <a href="../Skills/Skills">
                    <b>Skills</b><span> </span>
                </a>
                <ul class="submenu">
                    <li><a href="#">DotNet</a></li>
                    <li><a href="#">JAVA</a></li>
                    <li><a href="#">Python</a></li>
                    <li><a href="#">Datascience</a></li>
                    <li><a href="#">SQL</a></li>
                </ul>
            </li>
            <li class="submenu-wrapper">
                <a href="#">
                    <b>Interview Questions</b><span> </span>
                </a>
                <ul class="submenu">
                    <li><a href="#">DotNet</a></li>
                    <li><a href="#">JAVA</a></li>
                    <li><a href="#">Python</a></li>
                    <li><a href="#">Datascience</a></li>
                    <li><a href="#">SQL</a></li>
                </ul>
            </li>
            <li class="submenu-wrapper">
                <a href="#">
                    <b> contact Us</b><span> </span>
                </a>
                <ul class="submenu">
                    <li><a href="#">Email</a></li>
                    <li><a href="#">Mobile Numer</a></li>
                    <li><a href="#">Google Map</a></li>
                    <li><a href="#">Address</a></li>
                </ul>
            </li>
        </ul>
        <div>
            <button class="logout-button" onclick="logout()">Logout</button>
        </div>
    </nav>

    <div id="background-container">
        <img width="100%" height="100%" src="https://hitechinstitution.com/wp-content/uploads/2021/05/61764-2048x1280.jpg" />
        <div class="text-block">
            <p style="font-size: 2vw;">
                SLA<br />
                These platform provides a diverse range of resources for learners <br />
                to evaluate their current technical abilities and
                <br />discover ways to enhance their skills.
            </p>
        </div>
    </div>
       
    <script src="./script.js"></script>
    <script>const icon = document.querySelector('.icon');
        const menu = document.querySelector('.menu');
        const span = document.querySelector('.span')

        function toggleNavbar() {
            menu.classList.toggle('active');
            icon.classList.toggle('active');
            Button.classList.toggle('active');
        }
        document.querySelector('.toggle-btn').addEventListener('click', function () {
            toggleNavbar();
        });
        function logout() {
            alert("You have been logged out.");
            window.location.href = "login.html";
        }
        //document.getElementById('logoutButton').addEventListener('click', function () {
        //    function logout() {
        //        console.log('User logged out');
        //    }

        //    logout();
        //});
        document.addEventListener('DOMContentLoaded', function () {
            var container = document.getElementById('background-container');
            var imageUrl = 'https://hitechinstitution.com/wp-content/uploads/2021/05/61764-2048x1280.jpg';
            container.style.backgroundImage = 'url(' + imageUrl + ')';
        });</script>
     </body>
</html>