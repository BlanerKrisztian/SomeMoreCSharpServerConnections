const express = require("express")
const router = express.Router()

const factions = ["Tyrranids", "Automatons", "Squith", "GLA", "USA","Terran","Greenskins","Chaos","Nurgle","GDI","NOD","Danube Federation","Empire", "Deepwater Guard"]

router.get("/factions",(req,res) => {
    res.status(200).json({Message:"All factions I thought of",Factions:factions}).end()
})

router.post("/faction",(req,res) => {
    const newFaction = req.body.newFaction
    factions.push(newFaction)
    console.log(`Added new faction: ${newFaction}`)
    res.status(201).json({Message:`${newFaction} successfully added`}).end()
})

router.delete("/faction",(req,res) => {
    console.log(`Deleted a faction`)
    factions.pop()
    res.status(200).json({Message:`successfully Deleted a faction`}).end()
})

module.exports = router