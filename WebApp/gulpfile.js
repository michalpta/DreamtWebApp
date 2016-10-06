/// <binding />
/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var sass = require('gulp-sass');
var browserSync = require('browser-sync');

gulp.task('default', function () {
    // place code for your default task here
});

gulp.task('sass', function () {
    return gulp.src('./Content/sass/app.scss')
      .pipe(sass().on('error', sass.logError))
      .pipe(gulp.dest('./Content/css/'));
});
 
gulp.task('sass:watch', function () {
    gulp.watch('./Content/sass/**/*.scss', ['sass']);
});

gulp.task('browser-sync', function () {
    browserSync.init({
        proxy: "localhost:58160",
        files: ["Content/css/app.css", "index.html"]
    });
});