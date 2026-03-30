const express = require("express")
const dbHandler = require("./dbHandler")
const router = express.Router()

const factions = ["Tyrranids", "Automatons", "Squith", "GLA", "USA","Terran","Greenskins","Chaos","Nurgle","GDI","NOD","Danube Federation","Empire", "Deepwater Guard"]

router.get("/factions",(req,res) => {
    res.status(200).json({Message:"All factions I thought of",factions:factions}).end()
})

router.post("/faction",(req,res) => {
    const newFaction = req.body.newFaction
    factions.push(newFaction)
    console.log(`Added new faction: ${newFaction}`)
    res.status(200).json({Message:`${newFaction} successfully added`}).end()
})

router.delete("/faction",(req,res) => {
    console.log(`Deleted a faction`)
    factions.pop()
    res.status(200).json({Message:`successfully Deleted a faction`}).end()
})

// DB ----------------------------------------------


router.post("/weather", async (req,res) => {
    const { name, intensity, description } = req.body
    if (!name) {
        res.status(400).json({Message:"Missing data: name"}).end()
        return
    }
    else if (!intensity) {
        res.status(400).json({Message:"Missing data: intensity"}).end()
        return
    }
    else if (description > 255) {
        res.status(400).json({Message:"Description cannot exceed 255 characters"}).end()
        return
    }
    await dbHandler.weathertype.create({
        name, intensity, description
    })
    res.status(200).json({Message:"Successfull creation"}).end()
})



module.exports = router