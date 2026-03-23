const express = require("express")
const router = express.Router()

const factions = ["Tyrranids", "Automatons", "Squith", "GLA", "USA","Terran","Greenskins","Chaos","Nurgle","GDI","NOD","Danube Federation","Empire"]

router.get("/factions",(req,res) => {
    res.status(200).json({Message:"All factions I thought of"}).end()
})

module.exports = router