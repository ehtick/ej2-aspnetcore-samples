﻿function loadSparkLineTheme(args) {
    var theme = location.hash.split('/')[1];
    theme = theme ? theme : 'Tailwind3';
    args.sparkline.theme = (theme.charAt(0).toUpperCase() + theme.slice(1)).replace(/-dark/i, 'Dark').replace(/contrast/i, 'Contrast').replace(/-highContrast/i, 'HighContrast');
};