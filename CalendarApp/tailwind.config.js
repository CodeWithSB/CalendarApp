const colors = require("tailwindcss/colors");
module.exports = {
	purge: [],
	darkMode: "class", // or 'media' or 'class'
	theme: {
		extend: {
			minHeight: {
				20: "20px",
				160: "160px",
			},
			keyframes: {
				"fade-in": {
					"0%": { opacity: "0" },
					"100%": { opacity: "1" },
				},
			},
			animation: {
				"fade-in": "fade-in 1s ease-in-out normal",
			},
		},
	},
	variants: {
		extend: {
			animation: ["hover", "focus"],
			overflow: ["hover", "focus", "group-hover"],
		},
	},
	plugins: [],
};
