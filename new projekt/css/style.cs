body {
    font-family: 'Inter', 'Helvetica Neue', Helvetica, Arial, sans-serif;
    margin: 0;
    background-color: #f4f4f4;
    padding-bottom: 120px;
}

.top-nav {
    display: flex;
    justify-content: flex-end;
    padding: 15px 40px;
    background-color: #000;
}

.about-btn {
    color: #fff;
    text-decoration: none;
    font-size: 1.1rem;
    font-weight: bold;
    border: 2px solid #fff;
    padding: 6px 16px;
    border-radius: 4px;
    transition: background 0.3s, color 0.3s;
}

.about-btn:hover {
    background-color: #fff;
    color: #000;
}

.main-header {
    background: #000;
    color: #fff;
    padding: 60px 20px;
    text-align: center;
    margin-bottom: 40px;
}

.header-content {
    display: inline-block;
}

.main-header h1 {
    letter-spacing: 12px;
    margin: 0;
    font-size: 3rem;
    border-bottom: 6px solid #fff;
    padding-bottom: 15px;
}

.logo-shapes {
    display: flex;
    justify-content: center;
    align-items: center;
    gap: 25px;
    margin-top: 25px;
}

.logo-circle { width: 25px; height: 25px; background: #ff3333; border-radius: 50%; }
.logo-square { width: 23px; height: 23px; background: #3333ff; }
.logo-triangle { width: 0; height: 0; border-left: 14px solid transparent; border-right: 14px solid transparent; border-bottom: 24px solid #f39c12; }

.content-wrapper {
    padding: 0 40px;
    max-width: 1200px;
    margin: 0 auto;
    position: relative;
    z-index: 1;
}

.intro-text {
    margin-bottom: 60px;
    line-height: 1.8;
    color: #111;
    font-size: 1.25rem;
    max-width: 900px;
    text-align: center;
    margin-left: auto;
    margin-right: auto;
}

.section-title {
    font-size: 1.8rem;
    padding-bottom: 15px;
    margin-top: 140px;
    margin-bottom: 60px;
    letter-spacing: 2px;
    position: relative;
    z-index: 20;
}

.section-title::after {
    content: "";
    position: absolute;
    left: 0;
    bottom: 0;
    width: 100%;
    height: 3px;
    background-color: #000;
    z-index: 99 !important;
}

.section-title::before {
    content: "";
    position: absolute;
    left: 50%;
    top: 380px;
    transform: translate(-50%, -50%);
    z-index: -10 !important;
    opacity: 1.0;
    pointer-events: none;
}

.title-phases::before { width: 750px; height: 750px; background: #ff3333; border-radius: 50%; }
.title-meister::before { width: 700px; height: 700px; background: #3333ff; }
.title-werke::before { width: 0; height: 0; border-left: 450px solid transparent; border-right: 450px solid transparent; border-bottom: 800px solid #f39c12; top: 400px; }

.grid-container {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(280px, 1fr));
    gap: 30px;
    margin-bottom: 140px;
    position: relative;
    z-index: 30;
}

.card, .master-card {
    background: #fff;
    cursor: pointer;
    box-shadow: 0 4px 8px rgba(0,0,0,0.1);
    display: flex;
    flex-direction: column;
    overflow: hidden;
    transition: transform 0.3s;
    position: relative;
    z-index: 35;
}

.card:hover, .master-card:hover { transform: translateY(-10px); }

.phase-weimar { border-top: 15px solid #ff3333; }
.phase-dessau { border-top: 15px solid #3333ff; }
.phase-berlin { border-top: 15px solid #f39c12; }

.image-container { width: 100%; height: 250px; padding: 15px; box-sizing: border-box; }
.image-container img { width: 100%; height: 100%; object-fit: contain; }

.card-content { padding: 20px; }
.card-content h3 { margin: 0 0 10px 0; font-size: 1.3rem; }

.master-card { background: #000; color: #fff; }
.master-image-container { height: 300px; padding: 20px; box-sizing: border-box; }
.master-image-container img { width: 100%; height: 100%; object-fit: contain; filter: grayscale(100%); }
.master-content { padding: 25px; }
.master-role { font-size: 0.8rem; text-transform: uppercase; color: #aaa; }

.bauhaus-modal {
    border: 5px solid #000;
    padding: 50px;
    max-width: 800px;
    width: 90%;
    height: auto;
    background: #fff;
    position: fixed;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    box-shadow: 20px 20px 0px #000;
    z-index: 10000;
}

.bauhaus-modal::backdrop { background: rgba(0,0,0,0.8); }

.modal-grid {
    display: flex;
    gap: 20px;
    margin: 30px 0;
}

.modal-image-box {
    flex: 1;
    background: #eee;
    padding: 10px;
    text-align: center;
}

.modal-image-box img { width: 100%; height: 220px; object-fit: contain; display: block; }
.modal-image-box span { display: block; margin-top: 10px; font-weight: bold; font-size: 0.8rem; text-transform: uppercase; }

.modal-single-img { text-align: center; background: #f9f9f9; padding: 20px; margin-bottom: 20px; }
.modal-single-img img { max-width: 100%; height: 300px; object-fit: contain; }

.bauhaus-modal h2 { border-bottom: 4px solid #000; padding-bottom: 15px; margin-bottom: 25px; }
.bauhaus-modal p { line-height: 1.8; margin-bottom: 15px; }

.close-modal { position: absolute; top: 15px; right: 15px; background: #000; color: #fff; border: none; padding: 8px 15px; cursor: pointer; font-weight: bold; }
.close-modal:hover { background: #ff3333; }

.main-footer { background: #000; color: #fff; text-align: center; padding: 25px; position: fixed; bottom: 0; width: 100%; z-index: 100; }
.footer-link { color: #aaa; text-decoration: none; }

.impressum-container {
    max-width: 800px;
    margin: 40px auto 20px auto;
    background: #fff;
    padding: 40px;
    box-shadow: 0 4px 8px rgba(0,0,0,0.1);
    line-height: 1.8;
}

.impressum-container h1 {
    border-bottom: 3px solid #000;
    padding-bottom: 10px;
    margin-bottom: 20px;
}

.about-link {
    color: #3333ff;
    text-decoration: underline;
}

.about-link:hover {
    color: #000;
}

.page-bg-shapes {
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 30px;
    margin: 30px auto;
}

.page-shape-circle { width: 60px; height: 60px; background-color: #ff3333; border-radius: 50%; }
.page-shape-square { width: 55px; height: 55px; background-color: #3333ff; }
.page-shape-triangle { width: 0; height: 0; background-color: transparent; border-left: 30px solid transparent; border-right: 30px solid transparent; border-bottom: 55px solid #f39c12; }
