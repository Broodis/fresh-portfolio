.menu-toggle { position: fixed; top: 50px; left: 50px; z-index: 7; cursor: pointer; width: 61px; height: 61px; outline: 0; padding: 0; cursor: pointer; -webkit-transform: translate(0, 0); -ms-transform: translate(0, 0); transform: translate(0, 0); -webkit-transition: -webkit-transform 500ms cubic-bezier(0.645, 0.045, 0.355, 1); transition: -webkit-transform 500ms cubic-bezier(0.645, 0.045, 0.355, 1); transition: transform 500ms cubic-bezier(0.645, 0.045, 0.355, 1); transition: transform 500ms cubic-bezier(0.645, 0.045, 0.355, 1), -webkit-transform 500ms cubic-bezier(0.645, 0.045, 0.355, 1); background: #000; }

.menu-toggle .hamburger-bar { position: absolute; left: 22px; display: block; height: 2px; background-color: #fff; width: 17px; -webkit-transform: rotate(0deg); -ms-transform: rotate(0deg); transform: rotate(0deg); -webkit-transition: color 0.3s, background-color 0.3s; transition: color 0.3s, background-color 0.3s; }

.menu-toggle .hamburger-bar:nth-child(1) { top: 24px; }

.menu-toggle .hamburger-bar:nth-child(2) { top: 30px; }

.menu-toggle .hamburger-bar:nth-child(3) { top: 36px; }

.menu-toggle:hover { background-color: #fff; }

.menu-toggle:hover .hamburger-bar { background-color: #000; }

.touch .menu-toggle:hover .hamburger-bar { background-color: #000; }